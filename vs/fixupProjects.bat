ruby -pi.bak -e "gsub(/>MultiThreadedDebug</, '>MultiThreadedDebugDLL<')" libprotobuf.vcxproj
ruby -pi.bak -e "gsub(/>MultiThreaded</, '>MultiThreadedDLL<')" libprotobuf.vcxproj

ruby -pi.bak -e "gsub(/>MultiThreadedDebug</, '>MultiThreadedDebugDLL<')" libprotobuf-lite.vcxproj
ruby -pi.bak -e "gsub(/>MultiThreaded</, '>MultiThreadedDLL<')" libprotobuf-lite.vcxproj

ruby -pi.bak -e "gsub(/>MultiThreadedDebug</, '>MultiThreadedDebugDLL<')" libprotoc.vcxproj
ruby -pi.bak -e "gsub(/>MultiThreaded</, '>MultiThreadedDLL<')" libprotoc.vcxproj

ruby -pi.bak -e "gsub(/>MultiThreadedDebug</, '>MultiThreadedDebugDLL<')" protoc.vcxproj
ruby -pi.bak -e "gsub(/>MultiThreaded</, '>MultiThreadedDLL<')" protoc.vcxproj